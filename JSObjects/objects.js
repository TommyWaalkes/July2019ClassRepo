let person = {
    name: "tommy",
    age: 27,
    printInfo: function () {
        console.log(this.name);
        console.log(this.age);
    },
    add: function (x, y) {
        let result = x + y;
        return result;
    }
}



person.printInfo();

let a = person.add(2, 1);
console.log(a);

//document.getElementById("output").innerHTML = "Sup";

var paragraph = document.createElement('p');
paragraph.innerText = "I made a new tag!";
document.body.appendChild(paragraph);

//console.log(person);
