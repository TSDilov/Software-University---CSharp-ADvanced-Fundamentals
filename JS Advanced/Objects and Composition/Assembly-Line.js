function createAssemblyLine() {
    const object = {
        hasClima(carObject){
            carObject.temp = 21,
            carObject.tempSettings = 21,
            carObject.adjustTemp = () => {
                if (carObject.temp < carObject.tempSettings) {
                    carObject.temp++;
                }else if(carObject.temp > carObject.tempSettings){
                    carObject.temp--;
                }
            }
        },

        hasAudio(carObject){
            carObject.currentTrack = {};
            carObject.nowPlaying = () => {
                if (carObject.currentTrack.name != null && carObject.currentTrack.artist != null) {
                    console.log(`Now playing '${carObject.currentTrack.name}' by ${carObject.currentTrack.artist}` );
                }
            }
        },

        hasParktronic(carObject){
            carObject.checkDistance = (distance) => {
                if (distance < 0.1) {
                    console.log('Beep! Beep! Beep!');
                }else if (distance >= 0.1 && distance < 0.25) {
                    console.log('Beep! Beep!');
                }else if (distance >= 0.25 && distance < 0.5) {
                    console.log('Beep!');
                }else{
                    console.log('');
                }
            }
        }
    };

    return object;
}
const assemblyLine = createAssemblyLine();

const myCar = {
    make: 'Toyota',
    model: 'Avensis'
};
assemblyLine.hasClima(myCar);
console.log(myCar.temp);
myCar.tempSettings = 18;
console.log(myCar.tempSettings);
myCar.adjustTemp();
console.log(myCar.temp);
assemblyLine.hasAudio(myCar);
myCar.currentTrack = {
    name: 'Never Gonna Give You Up',
    artist: 'Rick Astley'
};
myCar.nowPlaying();
assemblyLine.hasParktronic(myCar);
myCar.checkDistance(0.4);
myCar.checkDistance(0.2);
console.log(myCar);