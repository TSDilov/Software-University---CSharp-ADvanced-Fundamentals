function heroicInventory(dataForHeroArray) {
    let dataForAllHeroes = [];
    for (let string of dataForHeroArray) {
        let [ name, level, items ] = string.split(' / ');
        let currentHero = {
            name,
            level: Number (level),
            items: items ? items.split(', ') : []
        }

        dataForAllHeroes.push(currentHero)
    }
    console.log(JSON.stringify(dataForAllHeroes));
}
heroicInventory(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']
);