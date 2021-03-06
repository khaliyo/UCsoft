﻿/*
 * ========================================================================
 * Copyright(c) 2013-2014 郑州优创科技有限公司, All Rights Reserved.
 * ========================================================================
 *  
 * 【实体类】
 *  
 *  
 * 作者：唐有炜   时间：2014-11-05 18:10:48
 * 文件名：TCusLog 
 * 版本：V1.0.0
 * 
 * 修改者：唐有炜           时间：2014-11-05 18:10:48            
 * 修改说明：修改说明
 * ========================================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using NLite.Data;
namespace UCsoft.Entity
{
	[Table("T_cus_log")]
	public partial class TCusLog 
	{
	
		[Id("id",IsDbGenerated=true)]
		public Int32 Id { get;set; }
 
		[Column("cus_id")]
		public Int32 CusId { get;set; }
		[Column("cus_type")]
		public String CusType { get;set; }
		[Column("cus_info")]
		public String CusInfo { get;set; }
		[Column("user_id")]
		public Int32? UserId { get;set; }
		[Column("cus_addtime")]
		public DateTime CusAddtime { get;set; }
 
 
 
	}
  
}




