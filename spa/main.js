const homeString = `<h1>Home Page</h1>`;
let aboutString = `<h1>About Page</h1>`;
const contactString = `<h1>Contact Page</h1>`;

function goHome(){
    document.querySelector("app-root").innerHTML = homeString;
}

function goAbout(){
    
    fetch("https://jsonplaceholder.typicode.com/todos").then(res=> res.json()).then(data=> {
        let text = "<ul>"
        for(let d of data){
            text += "<li>" + d.title + "</li>"
        }

        text += "</ul>"

        aboutString += text;

        document.querySelector("app-root").innerHTML = aboutString;
    });
}

function goContact(){
    document.querySelector("app-root").innerHTML = contactString;
}