## Introduction

- it's a sample and by design is wrong, models a real business scenario in the simplest possible way
- it's not fault tolerant, it's a sample
- it doesn't scale out, it's a sample
- utilizes SQLite and RavenDB Embedded, sooooo many issues

## master

- start from `master`
  - show home page
  - show a product page
- describe how composition works
- kill CustomerCare
  - fault tolerance super simple sample
- use case: _as a user I want to create a new product to be available in the store_

## create-stock-item

switch to `create-stock-item` branch:

- reset DBs
- **re-build all** and run showing new stuff
  - create a new `Stock Item`
- look at `Warehouse` projects
  - show new ViewComponents: Main menu, Views and Controllers
  - show changes in the API controller, especially message publish
  - show endpoint configuration in startup
- talk about message routing config, that in Warehouse is empty

## handles-stock-item-created

switch to `handles-stock-item-created` branch

- reset DBs
- **re-build all** and run showing new stuff
  - create a new `Stock Item`
  - hit the empty handler `breakpoint` in Marketing
  - show message routing config
- outline the process and the need of `coordination`

## product-draft-creation

switch to `product-draft-creation` branch

- reset DBs, now it'll be RavenDB
- **re-build all** and run showing:
  - create a new `Stock Item`
  - when a new StockItem is created
    - A product draft is automatically created
    - Stock Item details and Shipping costs are auto-magically there
  - Talk about shipping process as a sub-domain of `Warehouse`
  - Show the saga

## product-publishing

switch to `product-publishing` branch

- reset DBs
- **re-build all** and run showing:
  - Edit and Save a Product Draft
  - StockItem added to Home Page
  - How saga is completed
  - How proposed price is handled to be idempotent
  - No structures are created in Customer Care, it supports no ratings and no reviews

## monitoring-debugging

- if there's time left
  - reset DBs
  - publish a new product
  - show `Service Insight`
