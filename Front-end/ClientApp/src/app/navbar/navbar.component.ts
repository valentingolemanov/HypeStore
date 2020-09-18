import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../services/alertify.service';
import {
  Event,
  NavigationCancel,
  NavigationEnd,
  NavigationError,
  NavigationStart,
  Router
} from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  showFiller = false;
  loggedInUser: string;
  loading: boolean = false;

  constructor(private alertify: AlertifyService,
    private router: Router) {
    this.router.events.subscribe((event: Event) => {
      switch(true){
        case event instanceof NavigationStart: {
          this.loading = true;
          break;
        }

        case event instanceof NavigationEnd:
        case event instanceof NavigationCancel:
        case event instanceof NavigationError: {
          this.loading = false;
          break;
        }
        default: break;
      }
    })
   }

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
