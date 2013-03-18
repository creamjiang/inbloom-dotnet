﻿/*
 * Copyright 2013 Upeo, LLC
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this software except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using Newtonsoft.Json.Linq;

namespace inBloomApiLibrary
{
	public class SectionDataService : ServiceBase
	{
		/// <summary>
		///     Gets sections details.
		/// </summary>
		/// <param name="accessToken">Access token has to send</param>
		/// <param name="userId">User id  has to send</param>
		/// <returns>Gets Sections Data</returns>
		public JArray GetSections(string accessToken, string userId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections", userId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets section custom details.
		/// </summary>
		/// <param name="accessToken">Access token has to send</param>
		/// <param name="sectionId">User id  has to send</param>
		/// <returns>Gets Sections Data</returns>
		public JArray GetSectionCustom(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/custom", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets section  details by id.
		/// </summary>
		/// <param name="accessToken">Access token has to send</param>
		/// <param name="sectionId">User id  has to send</param>
		/// <returns>Gets Sections Data</returns>
		public JArray GetSectionById(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets Student section associations details within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionStudentAssociations(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/studentSectionAssociations", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets students details in student section associations within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionStudentAssociationStudentList(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/studentSectionAssociations/students", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets teacher section associations within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionTeacherAssociations(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/teacherSectionAssociations", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		/// <summary>
		///     Gets teachers in teacher section associations within the sections.
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public JArray GetSectionTeacherAssociationTeacherList(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/teacherSectionAssociations/teachers", sectionId);
			return ApiHelper.CallApiForGet(apiEndPoint, accessToken);
		}

		#region Create/Update/Delete Methods

		/// <summary>
		///     Creates sections details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public string PostSections(string accessToken, string data)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections");
			return ApiHelper.CallApiForPost(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Update sections details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="data"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public string PutSections(string accessToken, string data, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}/custom", sectionId);
			return ApiHelper.CallApiForPut(apiEndPoint, accessToken, data);
		}

		/// <summary>
		///     Deletes sectins details
		/// </summary>
		/// <param name="accessToken"></param>
		/// <param name="sectionId"></param>
		/// <returns></returns>
		public string DeleteSections(string accessToken, string sectionId)
		{
			string apiEndPoint = String.Format(ApiHelper.BaseUrl + "/sections/{0}", sectionId);
			return ApiHelper.CallApiForDelete(apiEndPoint, accessToken);
		}

		#endregion
	}
}