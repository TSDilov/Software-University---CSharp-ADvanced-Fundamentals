function carFactory(carObject) {
    let smallEngine = { power: 90, volume: 1800 };
    let normalEngine = { power: 120, volume: 2400 };
    let monsterEngine = { power: 200, volume: 3500 };

    let engineType = null;
    let carType = null  
    if (carObject.power <= 90) {
        engineType = smallEngine;
    }else if (carObject.power > 90 && carObject.power <= 120) {
        engineType = normalEngine; 
    }else{
        engineType = monsterEngine;
    }

    let hatchback = { type: 'hatchback', color: carObject.color };
    let coupe = { type: 'coupe', color: carObject.color };
    if (carObject.carriage === 'hatchback' ) {
        carType = hatchback;
    }else{
        carType = coupe;
    }

    let wheelsArray = [];
    for (let i = 0; i < 4; i++) {
        if (carObject.wheelsize % 2 === 0) {
            carObject.wheelsize--;
        } 
        wheelsArray.push(carObject.wheelsize);   
    }

    let asString = JSON.stringify(carObject);
    asString = asString.replace('power', 'engine');
    asString = asString.replace('wheelsize', 'wheels');
    carObject = JSON.parse(asString);
    carObject.engine = engineType;
    carObject.carriage = carType;
    carObject.wheels = wheelsArray;
    delete carObject.color;

    return carObject;
}
console.log(carFactory({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
));