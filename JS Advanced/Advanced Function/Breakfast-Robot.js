function solution() {
    let recipes = {
        "apple":  new Map(),
        "lemonade": new Map(),
        "burger": new Map(),
        "eggs": new Map(),
        "turkey": new Map()
    };

    recipes.apple.set("carbohydrate", 1);
    recipes.apple.set("flavour", 2);
    recipes.lemonade.set("carbohydrate", 10);
    recipes.lemonade.set("flavour", 20);
    recipes.burger.set("carbohydrate", 5);
    recipes.burger.set("fat", 7);
    recipes.burger.set("flavour", 3);
    recipes.eggs.set("protein", 5);
    recipes.eggs.set("fat", 1);
    recipes.eggs.set("flavour", 1);
    recipes.turkey.set("protein", 10);
    recipes.turkey.set("carbohydrate", 10);
    recipes.turkey.set("fat", 10);
    recipes.turkey.set("flavour", 10);
    
    const microelements = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };

    function restock(ingredient, quantity) {
        microelements[ingredient] += quantity;
        return 'Success';
    }

    function prepare(recipe, quantity) {
        for (let [key, value] of recipes[recipe]) {
            if (microelements[key] < value * quantity) {
                return `Error: not enough ${key} in stock`;
            }
        }

        for (let [key, value] of recipes[recipe]) {
            microelements[key] -= value * quantity;
        }

        return 'Success';
    }

    function report() {
        let result = '';
        Object.entries(microelements).forEach(el => {
            result += `${el[0]}=${el[1]} `;
        });

        return result.trimEnd();
    }

    return function(argument){
        argument = argument.split(' ');
        let command = argument[0];
        let microElementOrMeal = argument[1];
        let quantity = Number(argument[2]);
        
        switch (command) {
            case 'restock':
                return restock(microElementOrMeal, quantity);
            case 'prepare':
                return prepare(microElementOrMeal, quantity);
            case 'report':
                return report(); 
        }
    }
}
let manager = solution();
console.log (manager ('prepare turkey 1'));
console.log (manager ('restock protein 10'));
console.log (manager ('prepare turkey 1'));
console.log (manager ('restock carbohydrate 10'));
console.log (manager ('prepare turkey 1'));
console.log (manager ('restock fat 10'));
console.log (manager ('prepare turkey 1'));
console.log (manager ('restock flavour 10'));
console.log (manager ('prepare turkey 1'));
console.log (manager ('report'));