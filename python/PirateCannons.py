def cannons_ready(gunners):
  for pirate in gunners.values():
    if pirate == "nay":
      return "Shiver me timbers!"
  return "Fire!"

print(cannons_ready({'Mike':'aye','Joe':'aye','Johnson':'aye','Peter':'aye'}))
# should return "Fire"

print(cannons_ready({'Mike':'aye','Joe':'nay','Johnson':'aye','Peter':'aye'}))
# should return "Shiver me timbers"