import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpErrorResponse, HttpEventType } from  '@angular/common/http';
import { map } from  'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class UploadService {
  SERVER_URL: string = "https://localhost:53841/api/products/upload";
constructor(private httpClient: HttpClient) { }

public upload(formData) {

	return this.httpClient.post<any>(this.SERVER_URL, formData, {
      reportProgress: true,
      observe: 'events'
    });
}
}
