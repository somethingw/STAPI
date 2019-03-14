/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：报警报修接口
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-03-01 14:51:02
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.DAL
*│　类   名：Alarm_RepairDAL
*└──────────────────────────────────────────────────────────────┘
*/
using aliyun_api_gateway_sdk_ext.Model.request;
using aliyun_api_gateway_sdk_ext.Model.tenacy;
using aliyun_api_gateway_sdk_ext.Utils;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliyun_api_gateway_sdk_ext.DAL
{
    public class Alarm_RepairDAL: TenacyDbContext
    {
        
        public Alarm_RepairDAL(int ten_id):base(ten_id)
        {
            //显式调用父类构造器
        }

        public int setGarbageAlert(GarbageAlert garbageAlert)
        {
            //设置lora报警
            tp_node_alaert_now alert_Now = new tp_node_alaert_now();
            alert_Now.User_ID = 1;
            alert_Now.name = garbageAlert.source;
            alert_Now.dename = garbageAlert.source;
            alert_Now.typename = "垃圾报警";
            alert_Now.mark = garbageAlert.message;
            alert_Now.createtime = DateTime.Now;
            alert_Now.value = 0;//无意义
            alert_Now.devices_code = garbageAlert.source;
            alert_Now.sen_code = garbageAlert.source;
            alert_Now.type = 0;
            alert_Now.gaopei_ID = 1;
            alert_Now.devices_ID = 0;
            //首先查询目前在租户里有没有这个设备的对应设备，若是有，则可以直接找到id做对应。
            List<devices> device_list = Db.Queryable<devices>().
                                        Where(it => it.device_code == alert_Now.devices_code).
                                        ToList();
            if (device_list.Count > 0)
            {
                alert_Now.devices_ID = device_list[0].ID;//若有，则赋值id产生关联，之后可以做扩展
            }
            try
            {
                Db.Insertable(alert_Now).IgnoreColumns(it => new { it.ID }).ExecuteReturnIdentity();
                return 200;
            }
            catch
            {
                return 500;//服务器错误
            }
            return 200;
        }
        public int setLoraAlert(LoraAlert loraAlert )
        {
            //设置lora报警
            tp_node_alaert_now alert_Now = new tp_node_alaert_now();
            alert_Now.User_ID = 1;
            alert_Now.name = loraAlert.devicelocation;
            alert_Now.dename = loraAlert.deveui;
            alert_Now.typename = "Lora报警";
            alert_Now.mark = @"【状态】设备编号：" + loraAlert.deveui +
                                "<br/> 告警flag:" + loraAlert.flag +
                                "<br/>类型:" + loraAlert.alarmtype +
                               "<br/>设备位置:" + loraAlert.devicelocation +
                               "<br/>告警描述:" + loraAlert.alarmdesc +
                               "<br/>设备类型 :" + loraAlert.devtype +
                               "<br/>告警阈值:" + loraAlert.alarm_th +
                               "<br/>实际值:" + loraAlert.datavalue +
                               "<br/>告警等级:" + loraAlert.alarmlevel +
                               "<br/>处置意见:" + loraAlert.dealmsg;
            alert_Now.createtime = DateTime.Now;
            alert_Now.value = 0;//无意义
            alert_Now.devices_code = loraAlert.deveui;
            alert_Now.sen_code = loraAlert.devtype;
            alert_Now.type = 0;
            alert_Now.gaopei_ID = 1;
            alert_Now.devices_ID = 0;
            //首先查询目前在租户里有没有这个设备的对应设备，若是有，则可以直接找到id做对应。
            List<devices> device_list = Db.Queryable<devices>().
                                        Where(it => it.device_code == alert_Now.devices_code).
                                        ToList();
            if (device_list.Count > 0)
            {
                alert_Now.devices_ID = device_list[0].ID;//若有，则赋值id产生关联，之后可以做扩展
            }
            try
            {
                Db.Insertable(alert_Now).IgnoreColumns(it => new { it.ID }).ExecuteReturnIdentity();
                return 200;
            }
            catch
            {
                return 500;//服务器错误
            }
            
        }
        public int setFireControlAlert(FireControlAlert fireControlAlert)
        {
            tp_node_alaert_now alert_Now = new tp_node_alaert_now();
            alert_Now.User_ID = 1;
            alert_Now.name = fireControlAlert.sysAddr;
            alert_Now.dename = fireControlAlert.zoneCode +"_" +fireControlAlert.sysAddr + "_"+fireControlAlert.unitCode;//用三位拼接得到设备名
            alert_Now.typename = "消防报警";
            alert_Now.mark = "【状态】" + string.Join(",", fireControlAlert.status.ToArray()) + "/n" + "【备注】" + fireControlAlert.description;
            alert_Now.createtime = DateTime.Now;
            alert_Now.value = 0;//无意义
            alert_Now.devices_code = fireControlAlert.zoneCode + fireControlAlert.sysAddr + fireControlAlert .unitType+ fireControlAlert.unitCode;
            alert_Now.sen_code = fireControlAlert.unitType;
            alert_Now.type = 0;
            alert_Now.gaopei_ID = 1;
            alert_Now.devices_ID = 0;
            //消防报警报修,首先查询目前在租户里有没有这个设备的对应设备，若是有，则可以直接找到id做对应。
            List<devices> device_list = Db.Queryable<devices>().
                                        Where(it => it.device_code == alert_Now.devices_code).
                                        ToList();
            if (device_list.Count > 0)
            {
                alert_Now.devices_ID = device_list[0].ID;//若有，则赋值id产生关联，之后可以做扩展
            }
            try
            {
                Db.Insertable(alert_Now).IgnoreColumns(it => new { it.ID }).ExecuteReturnIdentity();
                return 200;
            }
            catch
            {
                return 500;//服务器错误
            }
            
        }
        public int setRepairOrder(Model.request.RepairOrder repairOrder)
        {
            
            //物业报修 by 王辉 2019-03-07
            SugarParameter ptid = new SugarParameter("@ptid", repairOrder.partCode);
            SugarParameter desc = new SugarParameter("@desc", repairOrder.detailed);
            SugarParameter address = new SugarParameter("@address", repairOrder.address);
            SugarParameter booktime = new SugarParameter("@booktime", repairOrder.appointDate);
            SugarParameter tel = new SugarParameter("@tel", repairOrder.phone);
            SugarParameter caller = new SugarParameter("@caller", repairOrder.contacts);
            SugarParameter accountid = new SugarParameter("@accountid", "");
            SugarParameter booktqid = new SugarParameter("@booktqid", repairOrder.appointTime);
            SugarParameter crsourceid = new SugarParameter("@crsourceid", 0);
            SugarParameter crpartid = new SugarParameter("@crpartid", null);
            try
            {
                Db.Ado.UseStoredProcedure().GetDataTable("insertCR", ptid, desc, address, booktime, tel, caller, accountid, booktqid, crsourceid, crpartid);
            }
            catch
            {
                return 500;
            }
            
            return 200;
        }

    }
}
