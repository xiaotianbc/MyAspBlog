﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
namespace MyAspBlog.Model
{
    public class BlogNews :BaseId
    {
        //nvarchar 更适合带中文的字符串
        [SugarColumn(ColumnDataType ="nvarchar(30)")]
        public string Title { get; set; }

        [SugarColumn(ColumnDataType ="text")]
        public string Content { get; set; }

        public DateTime LastModifiedTime { get; set; }

        public int BrowseCount { get; set; }

        public int LikeCount { get; set; }

        public int TypeId { get; set; }

        public int AuthorId { get; set; }


        /// <summary>
        /// 类型，不映射到数据库
        /// </summary>
        [SugarColumn(IsIgnore =true)]
        public TypeInfo TypeInfo { get; set; }

        [SugarColumn(IsIgnore = true)]
        public AuthorInfo AuthorInfo { get; set; }
    }
}
