import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {map} from 'rxjs/operators';
import {Observable} from 'rxjs';
import {Collection} from './../models/Collection';

@Injectable({
  providedIn: 'root'
})
export class CollectionsService {

constructor(private http: HttpClient) { }


getAllCollections(){
  return this.http.get('http://localhost:58341/api/collections').pipe(
    map(data => {

      const models: Array<Collection> = [];
      for(const id in data){
        if(data.hasOwnProperty(id)){
          models.push(data[id]);
        }
      }

      return models;
    })
  );

}

createCollection(collection: Collection){
  return this.http.post<Collection>('http://localhost:58341/api/collections', collection);
}

getCollection(id: number) : Observable<Collection>{
  return this.getAllCollections().pipe(
    map(propertiesArray => {
      return propertiesArray.find(p => p.Id === id);
    }))
}

deleteCollection(id: number){
  return this.http.delete('http://localhost:58341/api/collections/' + id);
}
}
