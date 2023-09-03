document.addEventListener("DOMContentLoaded", () => {

    let h1 = document.querySelector("h1");
    for (let i = 0; i < 1000; i++) {
        h1.textContent += String.fromCharCode(Math.floor(Math.random() * 60) + 65);
    }

});


let str = "";
for (let i = 0; i < 5000; i++) {
    h1.textContent += String.fromCharCode(Math.floor(Math.random() * 60) + 65);
}
console.log("Test about async and deffer");