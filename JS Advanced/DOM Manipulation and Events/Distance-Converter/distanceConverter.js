function attachEventsListeners() {
    let buttonElement = document.getElementById('convert');
    buttonElement.addEventListener('click', onConvert);

    function onConvert() {
        let typeOfDistanceToConvert = document.getElementById('inputUnits').value;
        let distanceForConvert = Number(document.getElementById('inputDistance').value);
        switch (typeOfDistanceToConvert) {
            case 'km':
                distanceForConvert *= 1000;
                break;
            case 'cm':
                distanceForConvert *= 0.01;
                break; 
            case 'mm':
                distanceForConvert *= 0.001;
                break;  
            case 'mi':
                distanceForConvert *= 1609.34;
                break; 
            case 'yrd':
                distanceForConvert *= 0.9144;
                break;
            case 'ft':
                distanceForConvert *= 0.3048;
                break;
            case 'in':
                distanceForConvert *= 0.0254;
                break;
        }

        let typeOfDistanceToConvertInto = document.getElementById('outputUnits').value;

        switch (typeOfDistanceToConvertInto) {
            case 'km':
                distanceForConvert /= 1000;
                break;
            case 'cm':
                distanceForConvert /= 0.01;
                break; 
            case 'mm':
                distanceForConvert /= 0.001;
                break;  
            case 'mi':
                distanceForConvert /= 1609.34;
                break; 
            case 'yrd':
                distanceForConvert /= 0.9144;
                break;
            case 'ft':
                distanceForConvert /= 0.3048;
                break;
            case 'in':
                distanceForConvert /= 0.0254;
                break;
        }

        document.getElementById('outputDistance').value = distanceForConvert;
    }
}