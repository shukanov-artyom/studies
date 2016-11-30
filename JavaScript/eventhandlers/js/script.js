function clickHandler() {
    console.log("Context: " + this);
}

function assignHandlers() {
    document.getElementById("button-handler").
        addEventListener("click", clickHandler);
    document.getElementById("button-onclick").
        onclick = clickHandler;
}

document.addEventListener("DOMContentLoaded", 
    assignHandlers);


