/**
 *  部门接口
 *  @module @/api/department
 */

import config from "@/config"
import http from "@/utils/request"

export default {

	/**
	 * 增加部门
	 */
	add :{
		url: `${config.API_URL}/department/add`,
		name: `增加部门`,
		post:async function(data) {
			return await http.post(this.url,data)
		}
	},


	/**
	 * 批量删除
	 */
	bulkDel :{
		url: `${config.API_URL}/department/bulk.del`,
		name: `批量删除`,
		post:async function(data) {
			return await http.post(this.url,data)
		}
	},


	/**
	 * 删除部门
	 */
	del :{
		url: `${config.API_URL}/department/del`,
		name: `删除部门`,
		post:async function(data) {
			return await http.post(this.url,data)
		}
	},


	/**
	 * 部门列表
	 */
	list :{
		url: `${config.API_URL}/department/list`,
		name: `部门列表`,
		post:async function(data) {
			return await http.post(this.url,data)
		}
	},


	/**
	 * 更新部门
	 */
	update :{
		url: `${config.API_URL}/department/update`,
		name: `更新部门`,
		put:async function(data) {
			return await http.put(this.url,data)
		}
	},

}