$(document).ready(function(){
    $("button").hide();
    
    $("p").hover(function(){
        $("div").fadeIn(3000);
        $("button").fadeIn(3500);
  });
  $("button").click(function(){
    $("button").hide();
    $("div").animate({left: '2000px'});
    document.getElementById("cc").innerHTML = "FREEDOM!!!!!!!!!!!!!!!"
  });
  
    });
