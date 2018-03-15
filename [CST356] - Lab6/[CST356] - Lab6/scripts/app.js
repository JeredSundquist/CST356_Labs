function displayRegistration()
{
    alert("displaying");

    
    var firstName = document.getElementById("firstName").value;
    var lastName = document.getElementById("lastName").value;
    var age = document.getElementById("age").value;
    var summary = firstName + " " + lastName + " is " + age + " years old.";

    document.getElementById("summary").innerText = summary;

    return false;
}