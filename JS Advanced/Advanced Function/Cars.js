function cars(input) {
    let carsObject = {};

    const commandObject = {
        create,
        createInherit,
        set,
        print
    }

    input.forEach(element => {
        let currentCommand = element.split(' ');
        let command = currentCommand[0];
        let name = currentCommand[1];
        if (command === 'create') {
            if (currentCommand[2]) {
               let inheriter = currentCommand[3];
               commandObject.createInherit(name, inheriter); 
            }else{
                commandObject.create(name);
            }

        }else if (command === 'set') {
            let key = currentCommand[2];
            let value = currentCommand[3];
            commandObject.set(name, key, value);
        }else{
            commandObject.print(name);
        }
    });

    function create(name){
        carsObject[name] = {};
    }

    function createInherit(name, inheriter) {
        create(name);
        let carObj = carsObject[name];
        carObj = Object.setPrototypeOf(carObj,carsObject[inheriter]);
    }

    function set(name, key, value) {
        carsObject[name][key] = value;
    }

    function print(name) {
        let print = '';
        let carToPrint = carsObject[name];
        for (let key in carToPrint) {
            print += `${key}:${carToPrint[key]},`;
        }

        console.log(print.slice(0, -1));
    }
}

cars(['create c1',
'create c2 inherit c1',
'set c1 color red',
'set c2 model new',
'print c1',
'print c2']);