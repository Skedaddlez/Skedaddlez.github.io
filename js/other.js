// JavaScript source code

function projclick(x,y) {
    var activep = document.getElementById("activeproject")
    var activept = document.getElementById("activeprojecttext")
    var activelk = document.getElementById("activeprojectlink")
    
    activep.style.width = "92%";
    activep.style.padding = "2%";    
    activept.innerHTML = document.getElementById(x).innerHTML;
    activep.style.backgroundImage = document.getElementById(y).style.backgroundImage;  
      
}


