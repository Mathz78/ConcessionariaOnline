import React, { Component } from 'react';
import corvete from './../images/corvete.jpg';
import mclaren from './../images/mclaren.jpg';
import skyline from './../images/skyline.jpg';

export class Home extends Component {
    static displayName = Home.name;
    
    render () {
        return (
        <div>
            <h1>Sejam bem-vindos!</h1>

            <div id="carouselExampleControls" class="carousel slide mt-4" data-ride="carousel">
                <div class="carousel-inner">
                        <div class="carousel-item active">
                            <img class="d-block w-100 rounded" src={skyline} alt="First slide"></img>
                        </div>
                    <div class="carousel-item">
                        <img class="d-block w-100 rounded" src={mclaren} alt="Second slide"></img>
                    </div>
                    <div class="carousel-item">
                        <img class="d-block w-100 rounded" src={corvete} alt="Third slide"></img>
                    </div>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
        </div>
        );
  }
}
