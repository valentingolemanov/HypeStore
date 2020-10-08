import { Injectable, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {map} from 'rxjs/operators';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SneakersService {

private BASE_URL = 'https://api.thesneakerdatabase.com/';

constructor(private httpClient: HttpClient) { }


getAllSneakers(){
  return this.httpClient.get(this.BASE_URL + 'v1/sneakers?limit=100').subscribe(data => {
    console.log(data);
  })
}

}
