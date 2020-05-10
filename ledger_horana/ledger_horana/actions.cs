using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ledger_horana
{
    interface actions
    {
         bool Login(String username, String password);
         void register(String name, String username, String password, String privilages, String addedBy);
         bool addCategory(String cname);
         bool addSubCategory(String category,String subCategory);
         void editSubCategory();
         bool addCredit(String category, String subCategory, String invoiceNo, String invDate,double invoiceValue, double paidValue, String cOrCheque, int bnn, String user, double igeshe, String weekNum, String dateNum);
         void editCredit();
         bool addDebit(String category, String subCategory, String invoiceNo, String invoiceDate, double invoiceValue, double paidValue, String cOrCheque, int bnn, String user, double igeshe,String weekNum,String dateNum);
         void editDebit();
         void getAdminAccess();

         String getCreditFinal();
         bool updateCredit(String igeshe);
         bool updateDebit(String debitNew);

        bool saveDueCheques();


        void saveCheque(String chequeNo,String chequeValue,DateTime dueDate,String bankName,String invoiceNo,String dateNum,String weekNo);




    }
}
