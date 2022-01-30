function roadRadar(speed, area) {
    let maxSpeed;
    let status;
    if (area === 'residential') {
        maxSpeed = 20;
    }else if (area === 'city') {
        maxSpeed = 50;
    }else if (area === 'interstate') {
        maxSpeed = 90;
    } else {
        maxSpeed = 130;
    } 
    if (speed <= maxSpeed) {
        console.log(`Driving ${speed} km/h in a ${maxSpeed} zone`);
    }else{
        let difference = speed - maxSpeed;
        let status = '';
        if (difference <= 20) {
            status = 'speeding';
        }else if (difference <= 40) {
            status = 'excessive speeding';
        } else {
            status = 'reckless driving';
        }
        console.log(`The speed is ${speed - maxSpeed} km/h faster than the allowed speed of ${maxSpeed} - ${status}`);
    }
}
roadRadar(40, 'city');
roadRadar(21, 'residential');
roadRadar(120, 'interstate');
roadRadar(200, 'motorway');