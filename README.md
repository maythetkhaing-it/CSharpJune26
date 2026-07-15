C# ADO.NET Notes
***What is ADO.NET?
ADO.NET (ActiveX Data Objects .NET)
- C# application နှင့် Database ကို ချိတ်ပြီး CRUD လုပ်ရန် Microsoft မှပေးထားသော Data Access Technology ဖြစ်သည်။

***ADO.NET vs ORM
ADO.NET	
	SQL ကို ကိုယ်တိုင်ရေးရ	
	Performance ကောင်း	
	SQL Control အပြည့်ရ	
	Learning Curve ပိုမြင့်	
	Large Project တွေမှာလည်း သုံးနိုင်	

ORM
	SQL ကို ORM က Generate လုပ်ပေး
	CRUD အတွက် အချိန်ကုန်သက်သာ
	SQL Control နည်း
	Beginner Friendly
	Project အရွယ်အစားနဲ့ မဆိုင်၊ လိုအပ်ချက်ပေါ်မူတည်

***Required Package - NuGet Package --> System.Data.SqlClient
***Connection String - Application နဲ့ Database ကို ဘယ်လိုချိတ်ရမလဲဆိုတဲ့ Information
eg.	Server=localhost; //server name
	Database=SchoolDB;//db name
	User Id=sa;		  //SQL Login
	Password=123456;  //password
	TrustServerCertificate=True;

***ADO.NET Flow
Connection String
        |
SqlConnection --> Database Connection
        |
Open()
        |
SqlCommand --> SQL Query ကို Execute လုပ်ဖို့
        |
Execute
        |
Read Result --> Database က Data ကို DataTable ထဲ Fill လုပ်ပေးရန်
        |
Close()

DataTable -->Table တစ်ခုစာ Data သိမ်း
DataSet   -->Table အများကြီး သိမ်းထားနိုင်
DataRow   -->Row တစ်ကြောင်း
DataColumn-->Column  တစ်ခု

***Execute Methods
	SELECT Result များ ဖတ်ရန် --> ExecuteReader() --> SqlDataAdapter.Fill()
	Insert, Update, Delete တို့လို Result မပြန်တဲ့ Query တွေအတွက် -->ExecuteNonQuery() -->  Affected Rows (1 row affected....)
	COUNT, MAX, MIN စတဲ့ Value တစ်ခုတည်း -->  ExecuteScalar() -->  eg. SELECT COUNT(*), SELECT MAX(Id)

***using Statement
	Connection ကို using နဲ့ရေးရင် 
	using(SqlConnection conn = new SqlConnection(cs))
		{

		} Block ပြီးတာနဲ့ Automatically Close ဖြစ်သွားတယ်

ကိုယ်တိုင် conn.Close(); မခေါ်လည်းရတယ်

***SQL Injection ကို ကာကွယ်ရန် --> cmd.Parameters.AddWithValue("@Name", txtName.Text); --> Parameter ပေးပြီးသုံးသင့်တယ် 
***Namespace
	File Scoped Namespace --> namespace SchoolSMS; // အသုံးများ
	Block Scoped Namespace --> namespace SchoolSMS{}
							

