import { Component, OnInit } from '@angular/core';
import {UsersService} from '../../services/users.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.css']
})
export class UserRegisterComponent implements OnInit {

  registrationForm: FormGroup;

  constructor(private service: UsersService) {}

  ngOnInit(): void {
    this.registrationForm = new FormGroup( {
      email: new FormControl(null, [Validators.required, Validators.email]),
      username: new FormControl(null, [Validators.required]),
      password: new FormControl(null, [Validators.required]),
      confirmPassword: new FormControl(null, [Validators.required]),

   }, this.passwordMatchingValidator);

  }

  passwordMatchingValidator(fg: FormGroup) : Validators{
      return fg.get('password').value === fg.get('confirmPassword').value ? null : {
        notMatched: true
      }
  }

  onSubmit(){

  }

}
