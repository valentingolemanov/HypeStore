import { Injectable, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class ProductsService{



  constructor(private http: HttpClient) { }

  getAllProducts(){
    return this.http.get('http://localhost:58341/api/products');
  }

}
