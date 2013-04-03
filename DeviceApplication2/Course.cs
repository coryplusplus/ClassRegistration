using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceApplication2
{
   public class Course
   {

       #region Instance Variables
       private string Select;
       private string CRN;
       private string Subj;
       private string Crse;
       private string Sec;
       private string Cmp;
       private string Cred;
       private string Title;
       private string Day;
       private string Time;
       private DateTime Start;   //ALD
       private DateTime End;     //ALD
       private DateTime StartDate;   //ALD
       private DateTime EndDate; //ALD
       private string Cap;
       private string Act;
       private string Rem;
       private string WL_Cap;
       private string WL_Act;
       private string WL_Rem;
       private string Instructor;
       private string Date;
       private string Location;
       private string Attr;

       #endregion

       #region Properties

       //   Properties
       public string select
       {
           get { return Select; }
           set { select = value; }
       }
       public string crn
       {
           get { return CRN; }
           set { CRN = value; }
       }
       public string subj
       {
           get { return Subj; }
           set { Subj = value; }
       }
       public string crse
       {
           get { return Crse; }
           set { Crse = value; }
       }
       public string sec
       {
           get { return Sec; }
           set { Sec = value; }
       }
       public string cmp
       {
           get { return Cmp; }
           set { Cmp = value; }
       }
       public string cred
       {
           get { return Cred; }
           set { Cred = value; }
       }
       public string title
       {
           get { return Title; }
           set { Title = value; }
       }
       public string day
       {
           get { return Day; }
           set { Day = value; }
       }
       public string time
       {
           get { return Time; }
           set { Time = value; }
       }
       public string cap
       {
           get { return Cap; }
           set { Cap = value; }
       }
       public string act
       {
           get { return Act; }
           set { Act = value; }
       }
       public string rem
       {
           get { return Rem; }
           set { Rem = value; }
       }
       public string wl_cap
       {
           get { return WL_Cap; }
           set { WL_Cap = value; }
       }
       public string wl_act
       {
           get { return WL_Act; }
           set { WL_Act = value; }
       }
       public string wl_rem
       {
           get { return WL_Rem; }
           set { WL_Rem = value; }
       }
       public string instructor
       {
           get { return Instructor; }
           set { Instructor = value; }
       }
       public string date
       {
           get { return Date; }
           set { Date = value; }
       }
       public string location
       {
           get { return Location; }
           set { Location = value; }
       }
       public string attr
       {
           get { return Attr; }
           set { Attr = value; }
       }
       public DateTime start
       {
           get { return Start; }
           set { Start = value; }
       }
       public DateTime end
       {
           get { return End; }
           set { End = value; }
       }
       public DateTime startDate
       {
           get { return StartDate; }
           set { StartDate = value; }
       }
       public DateTime endDate
       {
           get { return EndDate; }
           set { EndDate = value; }
       }

       #endregion

       #region Accessors
       /////////////////////////////Access/////////////////////////////////////
       public string getSelect() { return Select; }
       public string getCRN() { return CRN; }
       public string getSubj() { return Subj; }
       public string getCrse() { return Crse; }
       public string getSec() { return Sec; }
       public string getCmp() { return Cmp; }
       public string getCred() { return Cred; }
       public string getTitle() { return Title; }
       public string getDay() { return Day; }
       public string getTime() { return Time; }
       public string getCap() { return Cap; }
       public string getAct() { return Act; }
       public string getRem() { return Rem; }
       public string getWL_Cap() { return WL_Cap; }
       public string getWL_Act() { return WL_Act; }
       public string getWL_Rem() { return WL_Rem; }
       public string getInstructor() { return Instructor; }
       public string getDate() { return Date; }
       public string getLocation() { return Location; }
       public string getAttr() { return Attr; }

       #endregion

       #region Mutators
       ///////////////////////////////modifiy/////////////////////////////////////////////
       public void setSelect(string x) { Select = x; }
       public void setCRN(string x) { CRN = x; }
       public void setSubj(string x) { Subj = x; }
       public void setCrse(string x) { Crse = x; }
       public void setSec(string x) { Sec = x; }
       public void setCmp(string x) { Cmp = x; }
       public void setCred(string x) { Cred = x; }
       public void setTitle(string x) { Title = x; }
       public void setDay(string x) { Day = x; }
       public void setTime(string x) { Time = x; }
       public void setCap(string x) { Cap = x; }
       public void setAct(string x) { Act = x; }
       public void setRem(string x) { Rem = x; }
       public void setWL_Cap(string x) { WL_Cap = x; }
       public void setWL_Act(string x) { WL_Act = x; }
       public void setWL_Rem(string x) { WL_Rem = x; }
       public void setInstructor(string x) { Instructor = x; }
       public void setDate(string x) { Date = x; }
       public void setLocation(string x) { Location = x; }
       public void setAttr(string x) { Attr = x; }

       #endregion

       #region Printing
       public string shortprint_course()
       {
           
           string print = getCRN() + "  " + getSubj() + "   " + getCrse() + "   " + getSec();
           return print;


       }
       public string longprint_course()//Will append to it later when we decide what kind of
                                      //way the display will be laid out or whatever
       {
           return "blah";
       }

       #endregion

   }
}

