﻿using Mall.IServices;
using Mall.DTO.QueryModel;
using Mall.Web.Framework;


using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace Mall.Web.Areas.Admin.Controllers
{
    public class SensitiveWordController : BaseAdminController
    {
        // GET: Admin/SensitiveWord
        ISensitiveWordService _iSensitiveWordService;

        IWebHostEnvironment _hostingEnvironment;

        public SensitiveWordController(ISensitiveWordService iSensitiveWordService,
                IWebHostEnvironment environment)
        {
            _iSensitiveWordService = iSensitiveWordService;
            _hostingEnvironment = environment;
        }
        public ActionResult Management()
        {
            return View();
        }

        public JsonResult GetCategories()
        {
            var categories = _iSensitiveWordService.GetCategories();
            return Json(categories);
        }

        public JsonResult Add(string word, string category)
        {
            var service = _iSensitiveWordService;
            if (service.ExistSensitiveWord(word) == false)
            {
                var model = new Entities.SensitiveWordInfo() { SensitiveWord = word, CategoryName = category };
                service.AddSensitiveWord(model);
                return Json(new Result() { success = true, msg = "添加成功！" });
            }
            else
            {
                return Json(new Result() { success = false, msg = "该敏感关键词已存在！" });
            }
        }

        public JsonResult Eidt(int id, string word, string category)
        {
            var model = new Entities.SensitiveWordInfo() { Id = id, SensitiveWord = word, CategoryName = category };
            _iSensitiveWordService.UpdateSensitiveWord(model);
            return Json(new Result() { success = true, msg = "修改成功！" });
        }

        [UnAuthorize]
        public JsonResult List(int page, string keywords, int rows, string category)
        {
            var result = _iSensitiveWordService.GetSensitiveWords(new SensitiveWordQuery { SensitiveWord = keywords, CategoryName = category, PageNo = page, PageSize = rows });
            var words = result.Models.ToList().Select(item => new
            {
                Id = item.Id,
                SensitiveWord = item.SensitiveWord,
                CategoryName = item.CategoryName
            });
            var model = new { rows = words, total = result.Total };
            return Json(model);
        }

        [HttpPost]
        [UnAuthorize]
        public JsonResult Delete(int id)
        {
            _iSensitiveWordService.DeleteSensitiveWord(id);
            return Json(new Result() { success = true, msg = "删除成功！" });
        }

        [HttpPost]
        [UnAuthorize]
        public JsonResult BatchDelete(string ids)
        {
            var strArr = ids.Split(',');
            List<int> listid = new List<int>();
            foreach (var arr in strArr)
            {
                listid.Add(Convert.ToInt32(arr));
            }
            _iSensitiveWordService.BatchDeleteSensitiveWord(listid.ToArray());
            return Json(new Result() { success = true, msg = "批量删除成功！" });
        }

        [HttpPost]
        [UnAuthorize]
        public JsonResult ImportExcel()
        {
            if (Request.Form.Files.Count == 0)
            {
                return Json(new Result() { success = false, msg = "请上传文件！" });
            }
            else
            {
                int i = 0;
                var file = Request.Form.Files[i];
                if (null == file || file.Length <= 0)
                    return Json(new Result() { success = false, msg = "上传文件格式不正确！" });
                //if(Request.ContentLength > maxRequestLength)
                //{
                //    return Json(new Result() { success = false, msg = "文件大小超出限制！" });
                //}

                Random ra = new Random();
                string filename = DateTime.Now.ToString("yyyyMMddHHmmssffffff") + i
                    + Path.GetExtension(file.FileName);

                string DirUrl = _hostingEnvironment.ContentRootPath + "/temp/";
                if (!System.IO.Directory.Exists(DirUrl))      //检测文件夹是否存在，不存在则创建
                {
                    System.IO.Directory.CreateDirectory(DirUrl);
                }
                string path = AppDomain.CurrentDomain.BaseDirectory + "/temp/" + filename;

                using (var fileStream = new FileStream(path, FileMode.Create))
                    file.CopyToAsync(fileStream).Wait();


                DataTable dt = GetData(Path.Combine(path, filename));
                var service = _iSensitiveWordService;
                foreach (DataRow dr in dt.Rows)
                {
                    if (service.ExistSensitiveWord(dr[1].ToString()) == false)
                    {
                        var model = new Entities.SensitiveWordInfo() { CategoryName = dr[0].ToString(), SensitiveWord = dr[1].ToString() };
                        service.AddSensitiveWord(model);
                    }
                }
                return Json(new Result() { success = true, msg = "导入成功！" });

            }

        }

        public DataTable GetData(string filePath)
        {
            HSSFWorkbook hssfworkbook;
            #region//初始化信息
            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    hssfworkbook = new HSSFWorkbook(file);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            #endregion

            HSSFSheet sheet = (HSSFSheet)hssfworkbook.GetSheetAt(0);
            {
                DataTable table = new DataTable();
                IRow headerRow = sheet.GetRow(0);//第一行为标题行
                int cellCount = headerRow.LastCellNum;//LastCellNum = PhysicalNumberOfCells
                int rowCount = sheet.LastRowNum;//LastRowNum = PhysicalNumberOfRows - 1

                //handling header.
                for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                {
                    DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                    table.Columns.Add(column);
                }
                for (int i = (sheet.FirstRowNum + 1); i <= rowCount; i++)
                {
                    IRow row = sheet.GetRow(i);
                    DataRow dataRow = table.NewRow();

                    if (row != null)
                    {
                        for (int j = row.FirstCellNum; j < cellCount; j++)
                        {
                            if (row.GetCell(j) != null)
                                dataRow[j] = GetCellValue(row.GetCell(j));
                        }
                    }

                    table.Rows.Add(dataRow);
                }
                return table;
            }
        }

        /// <summary>
        /// 根据Excel列类型获取列的值
        /// </summary>
        /// <param name="cell">Excel列</param>
        /// <returns></returns>
        private static string GetCellValue(ICell cell)
        {
            if (cell == null)
                return string.Empty;
            switch (cell.CellType)
            {
                case CellType.Blank:
                    return string.Empty;
                case CellType.Boolean:
                    return cell.BooleanCellValue.ToString();
                case CellType.Error:
                    return cell.ErrorCellValue.ToString();
                case CellType.Numeric:
                case CellType.Unknown:
                default:
                    return cell.ToString();//This is a trick to get the correct value of the cell. NumericCellValue will return a numeric value no matter the cell value is a date or a number
                case CellType.String:
                    return cell.StringCellValue;
                case CellType.Formula:
                    try
                    {
                        HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(cell.Sheet.Workbook);
                        e.EvaluateInCell(cell);
                        return cell.ToString();
                    }
                    catch
                    {
                        return cell.NumericCellValue.ToString();
                    }
            }
        }
    }
}