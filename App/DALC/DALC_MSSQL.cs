using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
namespace DALC
{
public partial class MSSQL_DALC : IDALC
{
public Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID)
{
Owner o = new Owner();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID_Adv ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public void Delete_Owner ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OWNER", p);
}
public void Delete_User ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_USER", p);
}
public void Delete_User_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", p);
}
public void Delete_User_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_USER_BY_USERNAME", p);
}
public Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE)
{
Owner oOwner = new Owner();
oOwner.OWNER_ID = OWNER_ID;oOwner.CODE = CODE;oOwner.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE;oOwner.DESCRIPTION = DESCRIPTION;oOwner.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
return oOwner.OWNER_ID;
}
public long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE)
{
User oUser = new User();
oUser.USER_ID = USER_ID;oUser.OWNER_ID = OWNER_ID;oUser.USERNAME = USERNAME;oUser.PASSWORD = PASSWORD;oUser.USER_TYPE_CODE = USER_TYPE_CODE;oUser.IS_ACTIVE = IS_ACTIVE;oUser.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
return oUser.USER_ID;
}
public List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_DISTINCT_SETUP_TBL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TBL_NAME = GV<String>(X["TBL_NAME"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LAST_VALUE = GV<Int64>(X["LAST_VALUE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_TBL_SETUP ()
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_TBL_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.EXISTS = EXISTS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHECK_USER_EXISTENCE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
EXISTS = p.EXISTS;
return oList;
}
public List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME; p.ISSYSTEM = ISSYSTEM; p.ISDELETEABLE = ISDELETEABLE; p.ISUPDATEABLE = ISUPDATEABLE; p.ISVISIBLE = ISVISIBLE; p.ISDELETED = ISDELETED; p.DISPLAY_ORDER = DISPLAY_ORDER; p.CODE_VALUE_EN = CODE_VALUE_EN; p.CODE_VALUE_FR = CODE_VALUE_FR; p.CODE_VALUE_AR = CODE_VALUE_AR; p.ENTRY_DATE = ENTRY_DATE; p.ENTRY_USER_ID = ENTRY_USER_ID; p.NOTES = NOTES;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EDIT_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_PARAMETERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.PARAM_NAME = GV<String>(X["PARAM_NAME"]);o.PARAM_TYPE = GV<String>(X["PARAM_TYPE"]);o.IS_OUTPUT = GV<Boolean>(X["IS_OUTPUT"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_RESULT_SCHEMA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.COLUMN_NAME = GV<String>(X["COLUMN_NAME"]);o.COLUMN_TYPE = GV<String>(X["COLUMN_TYPE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.@tableName = @tableName;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GENERATE_INSERT_STATEMENTS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE; p.VALUE = VALUE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
VALUE = p.VALUE;
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.ISDELETED = ISDELETED; p.ISVISIBLE = ISVISIBLE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_CREDENTIALS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
}
}
