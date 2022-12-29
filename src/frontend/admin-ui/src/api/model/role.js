/**
 *  角色接口
 *  @module @/api/role
 */

import config from "@/config"
import http from "@/utils/request"

export default {

/**
 * 增加角色
 */
add :{
  url: `${config.API_URL}/role/add`,
  name: `增加角色`,
  post:async function(data) {
    return await http.post(this.url,data)
  }
},


/**
 * 批量删除
 */
bulkDel :{
  url: `${config.API_URL}/role/bulk.del`,
  name: `批量删除`,
  post:async function(data) {
    return await http.post(this.url,data)
  }
},


/**
 * 删除角色
 */
del :{
  url: `${config.API_URL}/role/del`,
  name: `删除角色`,
  post:async function(data) {
    return await http.post(this.url,data)
  }
},


/**
 * 角色列表
 */
list :{
  url: `${config.API_URL}/role/list`,
  name: `角色列表`,
  post:async function(data) {
    return await http.post(this.url,data)
  }
},


/**
 * 更新角色
 */
update :{
  url: `${config.API_URL}/role/update`,
  name: `更新角色`,
  put:async function(data) {
    return await http.put(this.url,data)
  }
},

}