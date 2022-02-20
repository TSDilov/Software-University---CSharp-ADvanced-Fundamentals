function attachEventsListeners() {
    let daysInputElement = document.getElementById('days');
    let hoursInputElement = document.getElementById('hours');
    let minutesInputElement = document.getElementById('minutes');
    let secondsInputElement = document.getElementById('seconds');
    
    let numbersForCalculation = {
        days: 1,
        hours: 24,
        minutes: 1440,
        seconds: 86400
    }

    let daysConvertElement = document.getElementById('daysBtn');
    let hoursConvertElement = document.getElementById('hoursBtn');
    let minutesConvertElement = document.getElementById('minutesBtn');
    let secondsConvertElement = document.getElementById('secondsBtn');

    daysConvertElement.addEventListener('click', toConvert);
    hoursConvertElement.addEventListener('click', toConvert);
    minutesConvertElement.addEventListener('click', toConvert);
    secondsConvertElement.addEventListener('click', toConvert);

    function convert(value, id) {
        let calculator = value / numbersForCalculation[id];
        return {
            days: calculator,
            hours: calculator * numbersForCalculation.hours,
            minutes: calculator * numbersForCalculation.minutes,
            seconds: calculator * numbersForCalculation.seconds
        }
    }

    function toConvert(event) {
        let input = event.target.parentElement.querySelector('input[type="text"]');
        let time = convert(Number(input.value), input.id);
        daysInputElement.value = time.days;
        hoursInputElement.value = time.hours;
        minutesInputElement.value = time.minutes;
        secondsInputElement.value = time.seconds;
    }
}