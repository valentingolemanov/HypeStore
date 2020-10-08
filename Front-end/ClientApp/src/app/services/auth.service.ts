import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { shareReplay } from 'rxjs/operators';
import {User} from './../models/User';



@Injectable({
  providedIn: 'root'
})
export class AuthService {

constructor(private httpClient: HttpClient) { }



login(email: string, password: string){
    return this.httpClient.post<User>('http://localhost:58341/api/authenticate/login', {email , password});

}

register(email: string, password: string, username: string){
  return this.httpClient.post<User>('http://localhost:58341/api/authenticate/register', {email , password, username});

}


}
