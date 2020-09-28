import { Component, OnInit, Inject } from '@angular/core';
import {
  FormGroup,
  Validators,
  FormBuilder,
  FormControl,
} from '@angular/forms';
import { Router } from '@angular/router';
import { CollectionsService } from './../../../../services/collections.service';
import { AlertifyService } from './../../../../services/alertify.service';
import { Collection } from './../../../../models/Collection';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import {MatTable} from '@angular/material/table';
@Component({
  selector: 'app-add-collection',
  templateUrl: './add-collection.component.html',
  styleUrls: ['./add-collection.component.css'],
})
export class AddCollectionComponent implements OnInit {
  addCollectionForm: FormGroup;
  newCollection: any = {};

  collectionsLength: number;
  homeDisplayPositions: Array<number>;
  table: MatTable<any>;

  constructor(
    private fb: FormBuilder,
    private collectionsService: CollectionsService,
    private alertify: AlertifyService,
    private router: Router,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.collectionsLength = data['collectionsLength'];
    this.table = data['table'];
    console.log(this.table);
    this.homeDisplayPositions = Array.from({length: this.collectionsLength+1}, (_, i) => i + 1);
  }

  ngOnInit() {
    this.createAddCollectionForm();

  }

  // -----------------------------------
  // Getter method for all form controls
  // -----------------------------------
  get title() {
    return this.addCollectionForm.get('title') as FormControl;
  }
  get description() {
    return this.addCollectionForm.get('description') as FormControl;
  }
  get imageUrl() {
    return this.addCollectionForm.get('imageUrl') as FormControl;
  }
  get homeDisplay() {
    return this.addCollectionForm.get('homeDisplay') as FormControl;
  }

  createAddCollectionForm(): void {
    this.addCollectionForm = this.fb.group({
      name: [
        null,
        [
          Validators.required,
          Validators.minLength(2),
          Validators.maxLength(100),
        ],
      ],
      description: [
        null,
        [
          Validators.required,
          Validators.minLength(40),
          Validators.maxLength(1000),
        ],
      ],
      imageUrl: [null, [Validators.required]],
      homeDisplay: [false, [Validators.required]],
      displayRows: [null],
      displayCols: [null],
      displayPositionIndex: [null],
    });
  }

  onSubmit() {
    if (this.addCollectionForm.valid) {
      this.newCollection = Object.assign(
        this.newCollection,
        this.addCollectionForm.value
      );

      this.collectionsService.createCollection(this.newCollection).subscribe(
        (res) => {

        },
        (err) => console.log(err),
        () => {
          this.alertify.success('Congrats, you added a new collection!');
          this.addCollectionForm.reset();

        }
      );
    } else {
      console.log(this.addCollectionForm);
      this.alertify.error('Please provide valid information in all fields!');
    }
  }
}
