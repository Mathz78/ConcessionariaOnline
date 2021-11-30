import React, { Component } from 'react';
import './Login.css';

export class Login extends Component {
    static displayName = Login.name;
    
    
    render () {
        return (
        <div>
            <div class="wrapper fadeInDown mt-5">
                <div id="formContent">

                    <div class="fadeIn first mt-2">
                        <i class="fa fa-users fa-2x"></i>
                    </div>

                    <form>
                        <input type="text" id="login" class="fadeIn second" name="login" placeholder="login"></input>
                        <input type="text" id="password" class="fadeIn third" name="login" placeholder="password"></input>
                        <input type="submit" class="fadeIn fourth" value="Log In"></input>
                    </form>

                    <div id="formFooter">
                        <a class="underlineHover" href="#">Forgot Password?</a>
                    </div>
                </div>
            </div>
        </div>
        );
  }
}
