using BLC;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Declaration And Initialization Section.
            string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
            BLC.BLCInitializer oBLCInitializer = new BLC.BLCInitializer();
            oBLCInitializer.ConnectionString = _ConnectionString;
            oBLCInitializer.OwnerID = 1;
            oBLCInitializer.UserID = 1;            
            BLC.BLC oBLC = new BLC.BLC(oBLCInitializer);          
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            Academic_year oAcademic_year = oBLC.Get_Academic_year_By_ACADEMIC_YEAR_ID
                                            (
                                                new Params_Get_Academic_year_By_ACADEMIC_YEAR_ID() 
                                                { 
                                                    ACADEMIC_YEAR_ID = 2 
                                                } 
                                            );
            oAcademic_year.NAME = "Wow";
            oBLC.Edit_Academic_year(oAcademic_year);
        }
    }
}
