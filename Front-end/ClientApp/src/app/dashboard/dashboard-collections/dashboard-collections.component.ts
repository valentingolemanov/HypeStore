import { Component, OnInit } from '@angular/core';
import {MatDialog} from '@angular/material/dialog';
import {AddCollectionComponent} from './add-collection/add-collection.component';

@Component({
  selector: 'app-dashboard-collections',
  templateUrl: './dashboard-collections.component.html',
  styleUrls: ['./dashboard-collections.component.css']
})
export class DashboardCollectionsComponent implements OnInit {

  constructor(private dialog: MatDialog) { }

  ngOnInit() {
  }

  openAddCollectionDialog(){
    const dialogRef = this.dialog.open(AddCollectionComponent);

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }
}
