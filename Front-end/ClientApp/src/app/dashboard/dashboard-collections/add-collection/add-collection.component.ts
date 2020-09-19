import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder, FormControl } from '@angular/forms';
import {Router} from '@angular/router';
import {CollectionsService} from './../../../services/collections.service';
import {AlertifyService} from './../../../services/alertify.service';
import { Collection } from 'src/app/models/Collection';

@Component({
  selector: 'app-add-collection',
  templateUrl: './add-collection.component.html',
  styleUrls: ['./add-collection.component.css']
})
export class AddCollectionComponent implements OnInit {

  addCollectionForm: FormGroup;
  newCollection: any = {};

  constructor(private fb: FormBuilder,
    private collectionsService: CollectionsService,
    private alertify: AlertifyService,
    private router: Router) { }


  ngOnInit() {
    this.createAddCollectionForm();
  }

 // -----------------------------------
  // Getter method for all form controls
  // -----------------------------------
  get title(){
    return this.addCollectionForm.get('title') as FormControl;
  }
  get description(){
    return this.addCollectionForm.get('description') as FormControl;
  }
  get imageUrl(){
    return this.addCollectionForm.get('imageUrl') as FormControl;
  }

  createAddCollectionForm(): void {
    this.addCollectionForm = this.fb.group({
     name: [null, [Validators.required, Validators.minLength(2), Validators.maxLength(100)]],
     description: [null, [Validators.required, Validators.minLength(40), Validators.maxLength(1000)]],
     imageUrl: [null, [Validators.required]]
    });
  }

  onSubmit(){
    if(this.addCollectionForm.valid){

      this.newCollection = Object.assign(this.newCollection, this.addCollectionForm.value);
      let newCollectionId;
      this.collectionsService.createCollection(this.newCollection).subscribe(res => {
        newCollectionId = res;

      },
      (err) => console.log(err),
      () => {
        this.alertify.success("Congrats, you added a new collection!");
      this.addCollectionForm.reset();
       this.router.navigate([`/dashboard-collections`]);
    });

    }else{
      console.log(this.addCollectionForm);
      this.alertify.error("Please provide valid information in all fields!");
    }

    console.log(this.addCollectionForm);
  }

}
