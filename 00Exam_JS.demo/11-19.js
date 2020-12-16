var text={
	count: 0,
	im: 0,
}
function chimp(y){
	if (y < 10) {
		return (y + " is <b>ew!</b>");
	}
	else {
		return (y + " is <b>cool!</b>");
	}
}

var sum_j = text.im + text.count;
var oo = chimp(sum_j);
var sum = "<h3>it's undeniable that that all of text's objects are all summated to: </h3>"+sum_j+" and "+ oo; 

document.getElementById("demo00").innerHTML = "black cow "+text.count;
document.getElementById("demo01").innerHTML = sum;
document.getElementById("demo02").innerHTML = "anyways....<br>"+"diarrhea be like:<br>";

