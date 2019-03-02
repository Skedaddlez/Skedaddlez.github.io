// JavaScript source code

function projclick(x,y,z) {
    var activep = document.getElementById("activeproject")
    var activept = document.getElementById("activeprojecttext")
    var activelk = document.getElementById("activeprojectlink")

    var activelk2 = document.getElementById(z)
    var link = activelk2.getAttribute("href");    

    activep.style.maxHeight = "1000px";
    activep.style.padding = "2%";
    activep.setAttribute("onclick", "window.open('" + link +"')");
    activep.setAttribute("target", "_blank");
    activept.innerHTML = document.getElementById(x).innerHTML;
    activep.style.backgroundImage = document.getElementById(y).style.backgroundImage;  
      
}


