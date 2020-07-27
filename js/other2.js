// JavaScript source code

function blogclick(x, y, z) {
    window.scrollTo(0, 0);
    window.scrollTo(0, 0);
    var activep = document.getElementById("activeblog")
    var activept = document.getElementById("activeprojecttext")
    var activelk = document.getElementById("activeprojectlink")

    var activelk2 = document.getElementById(z)
    var link = activelk2.getAttribute("href");    

    activep.style.maxHeight = "800px";
    activep.style.padding = "2%";
    activept.innerHTML = document.getElementById(x).innerHTML;
    activep.style.backgroundImage = document.getElementById(y).style.backgroundImage;  
      
}


