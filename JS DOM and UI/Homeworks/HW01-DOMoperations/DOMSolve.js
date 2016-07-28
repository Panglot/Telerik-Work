/**
 * Created by softwareacademy on 27-Jul-16.
 */
function solve() {
    return function (indendificator, content) {
        var counter = 0,
            len = content.length,
            elemTemplate;


        if (typeof indendificator === "string") {
            indendificator = document.getElementById(indendificator);
        }
        if (!indendificator || !(indendificator instanceof HTMLElement) || !content) {
            throw new Error("Invalid HTML element or selector");
        }

        for(;counter<len; counter+=1){
            if(typeof content[counter] !== "string" && typeof content[counter] !== "number"){
                throw new Error("Invalid content type");
            }
        }

        counter = 0;

        while (indendificator.firstChild){
            indendificator.removeChild(indendificator.firstChild);
        }

        elemTemplate = document.createElement("div");

        for ( ; counter< len; counter+=1){
            elemTemplate.innerHTML = content[counter];
            indendificator.appendChild(elemTemplate.cloneNode(true));
        }

    };
}