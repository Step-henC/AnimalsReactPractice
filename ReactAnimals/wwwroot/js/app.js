import { animals } from './animals';
import React from 'react';
import ReactDOM from 'react-dom';


function displayFact(e) {
    const selectedAnimal = e.target.alt;

    const animalInfo = animals[selectedAnimal];

    const myIndex = Math.floor(Math.random() * animalInfo.facts.length);

    const funFact = animalInfo.facts[myIndex];

    document.getElementById('fact').innerHTML = funFact;

}


const title = '';

const background = <img className='background'
    src={'C:\Users\steve\repos\ReactAnimals\Pages\Shared\ocean.jpg'}
    alt='ocean' />;
const images = [];

for (const animal in animals) {
    images.push(<img

        key={animal}

        className='animal'
        alt={animal}
        src={animals[animal].image}

        ariaLabel={animal}
        role='button'
        onClick={displayFact}

    />)
}

const showBackground = true;
const animalFacts = (
    <div>
        <h1>{title == '' ? 'Click an animal for a fun fact' : title}</h1>
        {showBackground && background}

        <div className='animals'>{images} </div>

        <p id='fact'></p>
    </div>
);

ReactDOM.render(

    animalFacts, document.getElementById('root')
);
