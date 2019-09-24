class Country {
    constructor(name, lang, greeting, colors) {
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
    }
}
let usa = new Country("USA", "Murican", "Why Hello there world! Have some McDonalds", ["red", "white", "blue"]);
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"]);
let algeria = new Country("Algeria", "Arabic and Berber", "Sup", ["blue", "yellow", "red"])
let Rome = new Country("Rome", "Latin", "Salve Munde!", ["red", "gold", "purple"]);
let China = new Country("China", "Chineese", "Nihao!", ["red", "yellow", "yellow"]);

let countries = [];
countries.push(usa, mexico, algeria, Rome, China);
function MakeCountryDropDown() {
    let list = document.getElementById("CountryList");
    for (let i = 0; i < countries.length; i++) {
        let option = document.createElement("option");
        option.value = countries[i].name;
        option.innerText = countries[i].name;
        list.appendChild(option);
    }
}

function SwitchCountry() {
    // let input = prompt("Type in a country");
    let c = document.getElementById("CountryList");
    let country = countries[c.selectedIndex];

    let nameTag = document.getElementById("CountryName");
    nameTag.innerText = country.name;
    let langTag = document.getElementById("OfficialLanguage");
    langTag.innerText = country.lang;
    let helloTag = document.getElementById("HelloWorld");
    helloTag.innerText = country.greeting;

    let colorArray = country.colors;
    for (let i = 0; i < colorArray.length; i++) {
        let tag = "Color" + (i + 1);

        let colorTag = document.getElementById(tag);
        colorTag.style.backgroundColor = colorArray[i];
    }

}