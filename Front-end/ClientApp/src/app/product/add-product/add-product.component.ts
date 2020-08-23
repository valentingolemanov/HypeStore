import { Component, OnInit,ViewChild, ElementRef } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ProductsService } from 'src/app/services/products.service';
import { UploadService } from 'src/app/services/Upload.service';
import { HttpEventType, HttpErrorResponse } from '@angular/common/http';
import { map, catchError } from  'rxjs/operators';
import { of } from 'rxjs';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  addProductForm: FormGroup;
  @ViewChild("fileUpload", {static: false}) fileUpload: ElementRef;
  files  = [];

  constructor(private service: ProductsService, private uploadService: UploadService) {

   }

  ngOnInit() {
    this.addProductForm = new FormGroup( {
      title: new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(30)]),
      description: new FormControl(null, [Validators.required, Validators.minLength(10), Validators.maxLength(200)]),
      category: new FormControl(null),
      price: new FormControl(null, [Validators.required]),
      images: new FormControl(null, [Validators.required])
   });
  }

  uploadFile(file) {
    const formData = new FormData();
    formData.append('file', file.data);
    file.inProgress = true;
    this.uploadService.upload(formData).pipe(
      map(event => {
        switch (event.type) {
          case HttpEventType.UploadProgress:
            file.progress = Math.round(event.loaded * 100 / event.total);
            break;
          case HttpEventType.Response:
            return event;
        }
      }),
      catchError((error: HttpErrorResponse) => {
        file.inProgress = false;
        return of(`${file.data.name} upload failed.`);
      })).subscribe((event: any) => {
        if (typeof (event) === 'object') {
          console.log(event.body);
        }
      });
  }

  private uploadFiles() {
    this.fileUpload.nativeElement.value = '';
    this.files.forEach(file => {
      this.uploadFile(file);
    });
  }
  onClick() {
    const fileUpload = this.fileUpload.nativeElement;fileUpload.onchange = () => {
    for (let index = 0; index < fileUpload.files.length; index++)
   {
    const file = fileUpload.files[index];
     this.files.push({ data: file, inProgress: false, progress: 0});
    }
    this.uploadFiles();
   };
  fileUpload.click();
  }

  onSubmit(){
    console.log(this.addProductForm);
    const product = {
      Title: this.addProductForm.value['title'],
      Description: this.addProductForm.value['description'],
      Price: this.addProductForm.value['price'],
      Images: this.addProductForm.value['images']
    };

    console.log(product);
    this.service.createProduct(product).subscribe(res => {
      console.log(res);
    });
  }

}
