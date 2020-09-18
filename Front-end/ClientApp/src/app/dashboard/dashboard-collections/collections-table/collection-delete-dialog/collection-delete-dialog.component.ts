import { Component, OnInit, ViewChild } from '@angular/core';
import { CollectionsService } from 'src/app/services/collections.service';
import {MAT_DIALOG_DATA,} from "@angular/material/dialog";
import { Inject } from '@angular/core';
import { AlertifyService } from 'src/app/services/alertify.service';
import { Router } from '@angular/router';
import {MatTable} from '@angular/material/table';

@Component({
  selector: 'app-collection-delete-dialog',
  templateUrl: './collection-delete-dialog.component.html',
  styleUrls: ['./collection-delete-dialog.component.css']
})
export class CollectionDeleteDialogComponent implements OnInit {

  collectionId: number;


  constructor(private collectionsService: CollectionsService,
    @Inject(MAT_DIALOG_DATA) data,
    private alertify: AlertifyService,
    private router: Router) {
      this.collectionId = data.productId;
     }

  ngOnInit() {
  }

  onDelete(){
    this.collectionsService.deleteCollection(this.collectionId).subscribe(
      res => { console.log(res)},
      (err) => console.log(err),
      () =>{
         this.alertify.success('Congrats! You successfully deleted the collection');
         this.router.navigate(['/dashboard-collections']);
        }
    )
  }
}
