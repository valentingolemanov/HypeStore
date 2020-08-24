import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../services/alertify.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  showFiller = false;
  loggedInUser: string;

  constructor(private alertify: AlertifyService) { }

  ngOnInit(): void {
  }

  loggedIn(){
    this.loggedInUser = localStorage.getItem('token');
    return this.loggedInUser;
  }

  onLogout(){
    localStorage.removeItem('token');
    this.alertify.success('You are logged out')
  }

}
