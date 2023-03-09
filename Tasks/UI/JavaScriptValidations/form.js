// const Form = document.getElementById("Form");
// const Client_name = document.getElementById("Client_name");
// const Company = document.getElementById("Company");
// const Department = document.getElementById("Department");
// const Preferred_Contact_Method = document.getElementById("Email_input");
// const Company_Website = document.getElementById("Company_Website");
// const Company_logo = document.getElementById("Company_logo");
// const Logofile = document.getElementById("Logofile");
// const Billing_Date = document.getElementById("Billing_Date");
// const Additional_informationm = document.getElementById("Additional_information");
// // const Form = document.getElementById("Form");

function nameValidation(){
    let Cname = document.getElementById("Client_name");
    var letters =  /^[a-zA-Z *]{5,50}$/;
    if(Cname=="" || letters.test(Cname.value)==false){
        Cname.style.border="1px solid red";
        Cname.value="";
    }else{
        Cname.style.border="revert";
        console.log("Fine");
    }
    
}
function CompnyNameValidation(){
    var text = /^[a-zA-Z0-9 *]{5,50}$/;
    let CompanyName = document.getElementById("Company");
    if(CompanyName=="" || text.test(CompanyName.value)==false){
        CompanyName.style.border="1px solid red";
        CompanyName.value="";
    }else{
        CompanyName.style.border="revert";
        console.log("Fine");
    }
}
function DeptValidation(){
    let Dept = document.getElementById("Department");
    if(Dept.value==""){
        Dept.style.border="1px solid red";
    }else{
        Dept.style.border="revert";
    }
}
function EmailValidation(){
    var element = document.getElementById("Email");
    var regex = /^w+([.-]?w+)*@w+([.-]?w+)*(.w{2,3})+$/;
    if(element=="" || regex.test(element.value)==false){
        element.style.border="1px solid red";
        element.value="";
    }else{
        element.style.border="revert";
        console.log("Fine");
    }
}
function PhoneValidation(){
    var element = document.getElementById("Phone");
    var regex = /^[9]\d{9}$/;
    if(element=="" || regex.test(element.value)==false){
        element.style.border="1px solid red";
        element.value="";
    }else{
        element.style.border="revert";
        console.log("Fine");
    }

}
function zipValidation(){
    var number = /(^\d{6}$)/;
    var element = document.getElementById("zipcode");
    if(element=="" || number.test(element.value)==false){
        element.style.border="1px solid red";
        element.value="";
    }else{
        element.style.border="revert";
        console.log("Fine");
    }
}
function WebsiteValidation(){
    var element = document.getElementById("Company_Website");
    var pattern = "/(http?://.)?(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)/";
    if(element=="" || pattern.match(element.value)==false){
        element.style.border="1px solid red";
        element.value="";
    }else{
        element.style.border="revert";
        console.log("Fine");
    }
}
function DateValidation(){
    var element = document.getElementById("Billing_Date");
    let date = element.value.format('MMMM Do YYYY, h:mm:ss a');
    element.min = new Date().toLocaleDateString('en-ca');
     var element1=document.getElementById("billingdate");
     console.log(date);
     element1.innerHTML=element.value.innerHTML=element.value.toLocaleDateString('en-us', {day:"numeric",  month:"short", year:"numeric"});
    //  .toLocaleDateString('en-us', {day:"numeric",  month:"short", year:"numeric"});

}
document.getElementById('Emailinput').addEventListener("click",function(){
    document.getElementById("mail_field").style.display="inline-flex";
    document.getElementById("phone_field").style.display="none";
})
document.getElementById('Phoneinput').addEventListener("click",function(){
    document.getElementById("mail_field").style.display="none";
    document.getElementById("phone_field").style.display="inline-flex";
})