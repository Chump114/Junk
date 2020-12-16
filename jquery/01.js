const string0= "I am a string value";
$(document).ready(function(){
    $("#yeh").val(string0);
    $("#00").click(function(){
        alert(string0);
    });
    $("#01").click(function(){
        var n = $('a').prop('href');
        alert(n);
    });
});