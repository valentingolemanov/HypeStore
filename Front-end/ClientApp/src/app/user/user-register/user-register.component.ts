import { Component, OnInit } from '@angular/core';
import {UsersService} from '../../services/users.service';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { AlertifyService } from 'src/app/services/alertify.service';
import {Router} from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';


@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.css']
})
export class UserRegisterComponent implements OnInit {

  registrationForm: FormGroup;
  user: any = {};

  constructor(private service: UsersService,
     private fb: FormBuilder,
     private alertify: AlertifyService,
     private router: Router,
     private authService: AuthService) {}

  ngOnInit(): void {
   this.createRegistrationForm();

  }

  createRegistrationForm(){
    this.registrationForm = this.fb.group({
      email: [null, [Validators.required, Validators.email]],
      username: [null, Validators.required],
      password: [null, [Validators.required]],
      confirmPassword:[null, [Validators.required]]
     }, {validators: this.passwordMatchingValidator});
  }

  passwordMatchingValidator(fg: FormGroup) : Validators{
      return fg.get('password').value === fg.get('confirmPassword').value ? null : {
        notMatched: true
      }
  }


  //Getter method for all form controls
  get userName(){
    return this.registrationForm.get('username') as FormControl;
  }

  get email(){
    return this.registrationForm.get('email') as FormControl;
  }

  get password(){
    return this.registrationForm.get('password') as FormControl;
  }

  get confirmPassword(){
    return this.registrationForm.get('confirmPassword') as FormControl;
  }


  onSubmit(){

      this.authService.register(this.email.value, this.password.value, this.userName.value).subscribe(
        (data) => {

          this.alertify.success("Congrats, you can now log in to your account!")
          this.router.navigateByUrl('/login');
          this.registrationForm.reset();
        },
        error => {
          this.alertify.error("Invalid credentials")
        }
      )
  }


}
