let length = prompt("Please enter a length");
console.log(length);

let width = prompt("Please enter a width");

let area = calcArea(length, width);

console.log(area);

let p = calcPerim(length, width);

console.log(p);

function calcArea(x, y) {
    return x * y;
}

function calcPerim(length, width) {
    return 2 * length + 2 * width;
    //return 2(length + width);
}