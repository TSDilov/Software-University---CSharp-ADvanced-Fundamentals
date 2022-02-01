function timeToUniversity(stepsToUniversity, lengthOfStep, kmPerHour) {
    let distanceInM = stepsToUniversity * lengthOfStep;
    let kmToUniversity = distanceInM / 1000;
    let timeInMinutes = (kmToUniversity / kmPerHour) * 60;
    let restTime = (distanceInM - (distanceInM % 500)) / 500;
    timeInMinutes += restTime;
    let seconds;
    let minutes;
    let hours;
    if (timeInMinutes >= 60) {
        hours = Math.floor(timeInMinutes / 60);
        minutes = timeInMinutes - (hours * 60);
    }else{
        hours = 0;
        minutes = Math.floor(timeInMinutes);
    }
    seconds = Math.round((timeInMinutes - Math.floor(timeInMinutes)) * 60);

    console.log(`${hours.toString().padStart(2, '0')}:${minutes.toString().padStart(2, '0')}:${seconds}`);
}
timeToUniversity(4000, 0.6, 5);
timeToUniversity(2564, 0.70, 5.5)
