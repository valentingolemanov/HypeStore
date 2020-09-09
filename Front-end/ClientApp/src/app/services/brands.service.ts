import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {map} from 'rxjs/operators';
import {IBrand} from './../models/IBrand';

@Injectable({
  providedIn: 'root'
})
export class BrandsService {

constructor(private http: HttpClient) { }


    getAllBrands(){
      return this.http.get('http://localhost:58341/api/brands').pipe(
        map(data => {
          const models: Array<IBrand> = [];
          for(const id in data){
            if(data.hasOwnProperty(id)){
              models.push(data[id]);
            }
          }
          return models;
        })
      )
    }
}
