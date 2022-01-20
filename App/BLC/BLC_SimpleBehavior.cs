using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
#region Members
#region Used For Delete Operations
private Owner _Owner;
private User _User;
#endregion
#region Stop Executing Flags For Edit and Delete Operations
private bool _Stop_Edit_Owner_Execution;
private bool _Stop_Delete_Owner_Execution;
private bool _Stop_Edit_User_Execution;
private bool _Stop_Delete_User_Execution;
#endregion
#endregion
public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
{
Owner oOwner = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID");}
#region Body Section.
DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID");}
return oOwner;
}
public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID");}
return oUser;
}
public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
{
Owner oOwner = null;
List<Owner> oList = new List<Owner>();
Params_Get_Owner_By_OWNER_ID_List_SP oParams_Get_Owner_By_OWNER_ID_List_SP = new Params_Get_Owner_By_OWNER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID_List");}
#region Body Section.
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List");}
return oList;
}
public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID");}
return oList;
}
public List<User> Get_User_By_USERNAME(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME(i_Params_Get_User_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria(Params_Get_Owner_By_Criteria i_Params_Get_Owner_By_Criteria)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria.START_ROW == null) { i_Params_Get_Owner_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria.END_ROW == null) || (i_Params_Get_Owner_By_Criteria.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria(i_Params_Get_Owner_By_Criteria.CODE,i_Params_Get_Owner_By_Criteria.DESCRIPTION,i_Params_Get_Owner_By_Criteria.OWNER_ID,i_Params_Get_Owner_By_Criteria.START_ROW,i_Params_Get_Owner_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria");}
return oList;
}
public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where.OWNER_ID == null) || (i_Params_Get_Owner_By_Where.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where.START_ROW == null) { i_Params_Get_Owner_By_Where.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where.END_ROW == null) || (i_Params_Get_Owner_By_Where.END_ROW == 0)) { i_Params_Get_Owner_By_Where.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE,i_Params_Get_Owner_By_Where.DESCRIPTION,i_Params_Get_Owner_By_Where.OWNER_ID,i_Params_Get_Owner_By_Where.START_ROW,i_Params_Get_Owner_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2(Params_Get_Owner_By_Criteria_V2 i_Params_Get_Owner_By_Criteria_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria_V2.START_ROW == null) { i_Params_Get_Owner_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Owner_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria_V2(i_Params_Get_Owner_By_Criteria_V2.CODE,i_Params_Get_Owner_By_Criteria_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Criteria_V2.DESCRIPTION,i_Params_Get_Owner_By_Criteria_V2.OWNER_ID,i_Params_Get_Owner_By_Criteria_V2.START_ROW,i_Params_Get_Owner_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Where_V2(Params_Get_Owner_By_Where_V2 i_Params_Get_Owner_By_Where_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where_V2.START_ROW == null) { i_Params_Get_Owner_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where_V2.END_ROW == null) || (i_Params_Get_Owner_By_Where_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Where_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where_V2(i_Params_Get_Owner_By_Where_V2.CODE,i_Params_Get_Owner_By_Where_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Where_V2.DESCRIPTION,i_Params_Get_Owner_By_Where_V2.OWNER_ID,i_Params_Get_Owner_By_Where_V2.START_ROW,i_Params_Get_Owner_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where_V2");}
return oList;
}
public List<User> Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria");}
return oList;
}
public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where");}
return oList;
}
public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Owner");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Owner_Execution)
{
_Stop_Delete_Owner_Execution = false;
return;
}
_AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Owner");}
}
public void Delete_User(Params_Delete_User i_Params_Delete_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User(i_Params_Delete_User.USER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User");}
}
public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_OWNER_ID");}
}
public void Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USERNAME");}
}
public void Edit_Owner(Owner i_Owner) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Owner.OWNER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner");}
#region Body Section.
if ((i_Owner.OWNER_ID == null) || (i_Owner.OWNER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Owner"); }
i_Owner.ENTRY_DATE    = oTools.GetDateTimeString(DateTime.Now);
i_Owner.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Owner_Execution)
{
_Stop_Edit_Owner_Execution = false;
return;
}
i_Owner.OWNER_ID = _AppContext.Edit_Owner
(
i_Owner.OWNER_ID
,i_Owner.CODE
,i_Owner.MAINTENANCE_DUE_DATE
,i_Owner.DESCRIPTION
,i_Owner.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner");}
}
public void Edit_User(User i_User) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User.USER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User");}
#region Body Section.
if ((i_User.USER_ID == null) || (i_User.USER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User"); }
i_User.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_Execution)
{
_Stop_Edit_User_Execution = false;
return;
}
i_User.USER_ID = _AppContext.Edit_User
(
i_User.USER_ID
,i_User.OWNER_ID
,i_User.USERNAME
,i_User.PASSWORD
,i_User.USER_TYPE_CODE
,i_User.IS_ACTIVE
,i_User.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User");}
}
public void Edit_Owner_List(List<Owner> i_List_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Owner != null)
{
foreach (var oRow in i_List_Owner)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Owner_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Delete)
{
Delete_Owner(new Params_Delete_Owner() { OWNER_ID = oRow.OWNER_ID });
}
}
if (i_Params_Edit_Owner_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Edit)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_User_List(List<User> i_List_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User != null)
{
foreach (var oRow in i_List_User)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Delete)
{
Delete_User(new Params_Delete_User() { USER_ID = oRow.USER_ID });
}
}
if (i_Params_Edit_User_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Edit)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
}
}
