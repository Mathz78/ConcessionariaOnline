import React, { Component } from 'react';
import './Login.css';

export class Login extends Component {
    static displayName = Login.name;
    
    constructor(props) {
        super(props);

        this.updateLogin = this.updateLogin.bind(this);
        this.updatePassword = this.updatePassword.bind(this);

        this.state = {
            username : '',
            password: ''
        }
    }
    
    updateLogin(event){
        this.setState({username : event.target.value})
    }

    updatePassword(event){
        this.setState({password : event.target.value})
    }

    async checkUserCredentials(username, password) {
        const response = await fetch('/loginUser', {
            method: "POST",
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                "username": this.state.username,
                "password": this.state.password
            })
        });
    }


    render () {
        return (
        <div>
            <div class="wrapper fadeInDown mt-5">
                <div id="formContent">

                    <div class="fadeIn first mt-2">
                        <i class="fa fa-users fa-2x"></i>
                    </div>

                    <form>
                        <input type="text" id="login" class="fadeIn second" name="login" placeholder="login" onChange={this.updateLogin}></input>
                        <input type="text" id="password" class="fadeIn third" name="login" placeholder="password" onChange={this.updatePassword}></input>
                        <input type="submit" class="fadeIn fourth" value="Log In" onClick={() => this.checkUserCredentials(this.username, this.password)}></input>
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
