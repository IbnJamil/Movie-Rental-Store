window.onload = ready;
var i=0;
    function ready() {  
        var current = document.getElementById("pic" + i); 
        current.style.display = "none";
        var load = document.getElementById("pic" + ((i + 3)%5));
        load.style.display="block";  
        i++;
        if (i >= 5) i = 0;
        setTimeout("ready()", 2000);
    }
  
