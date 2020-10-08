import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { AuthService } from 'src/app/services/auth.service';
import {Router} from '@angular/router';
import { AlertifyService } from 'src/app/services/alertify.service';
import * as moment from "moment";

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {

  loginForm: FormGroup;
  hide = true;

  constructor(private fb: FormBuilder,
    private authService: AuthService,
    private router: Router,
    private alertify: AlertifyService,
    ) { }

  ngOnInit(): void {
    this.createLoginForm();
  }

  createLoginForm(){
    this.loginForm = this.fb.group({
      email: [null, [Validators.required, Validators.email]],
      password: [null, [Validators.required]],
     });
  }

  onLogin(){
    const val = this.loginForm.value;

    if (val.email && val.password) {
        this.authService.login(val.email, val.password)
            .subscribe(
                (data) => {

                  if(data['token']){
                   this.setSession(data);
                  }

                  this.alertify.success("User is logged in");
                  this.router.navigateByUrl('/');

                },
                error => {
                  console.log(error);
                  if(error['status'] === 401){
                    this.alertify.error("Invalid credentials");
                  }
                }

            );
    }

  }

  private setSession(authResult) {
    const expiresAt = moment().add(authResult.expiration,'second');

    localStorage.setItem('id_token', authResult.idToken);
    localStorage.setItem("expires_at", JSON.stringify(expiresAt.valueOf()) );
  }

}
