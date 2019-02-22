// JavaScript source code
// When the user scrolls the page, execute myFunction 
fontadapt();


function fontadapt() {
    var textarea = document.getElementsById("basesectdiv");
    var image = $("squimg");

    var offset = image.offset();
    textarea.setAttribute("style", "background-color: red;");
    p.html("left: " + offset.left + ", top: " + offset.top);
}

